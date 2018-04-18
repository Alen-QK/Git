import asyncio
import threading

#@asyncio.coroutine
async def wget(host):
    print("get is %s" % host)
    connect = asyncio.open_connection(host, 80)
    reader, writer = await connect
    header = 'GET / HTTP/1.0\r\nHost: %s\r\n\r\n' % host
    writer.write(header.encode('utf-8'))
    await writer.drain()
    while True:
        line = await reader.readline()
        if line == b'\r\n':
            break
        print('%s header > %s > %s' % (host, line.decode('utf-8').rstrip(), threading.current_thread()))
    
loop = asyncio.get_event_loop()
tasks = [wget(host) for host in ['www.bilibili.com', 'www.sohu.com', 'www.163.com']]
loop.run_until_complete(asyncio.wait(tasks))
loop.close()
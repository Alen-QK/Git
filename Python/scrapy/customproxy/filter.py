import urllib
import urllib.request
import time

def validateIp(ip, port):
    user_agent = 'Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11'
    headers = {'User-Agent': user_agent}
    proxy = {'http': 'http://%s:%s' % (ip,port)}
    
    proxy_handler = urllib.request.ProxyHandler(proxy)
    opener = urllib.request.build_opener(proxy_handler)
    urllib.request.install_opener(opener)

    validateUrl = 'https://music.douban.com/top250'
    req = urllib.request.Request(url= validateUrl, headers= headers)
    time.sleep(4)

    try:
        res = urllib.request.urlopen(req)
        time.sleep(2)
        content = res.read()
        if content:
            print('is ok')
            with open('data2.txt', 'a') as wd:
                wd.write(u"'" + ip + u':' + port + u"'" + u'\n')
        else:
            print('is not ok')
    except urllib.request.URLError as e:
        print(e.reason) 

if __name__ == '__main__':
    with open('data.txt', 'r') as rd:
        iplist = rd.readlines()
        for ip in iplist:
            validateIp(ip.split(u':')[0], ip.split(u':')[1])
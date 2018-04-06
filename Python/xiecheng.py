def consumer():
    r = ''
    while True:
        #2consumer通过yield拿到传递的None，yield跳出，consumer挂起
        n = yield r
        #4继续执行代码，输出刚刚从producer传进来的n值，并给r赋值
        if not n:
            return
        print('[C]Consume products %s' % n)
        r = '200 OK'
        #5开始循环，遇到yield返回值并跳出

def producer(c):
    #1启动生成器，跳入consumer
    c.send(None)
    #3继续执行接下来的代码，生产产品，在通过send(n)传值给consumer,并跳至consumer
    n = 0
    while n < 5:
        n = n + 1
        print('[P]Produce products %s' % n)
        r = c.send(n)#这里的r并不是一个特定变量，变量名称可以随意变更，和consumer中的r无关，比如改成a也可以正常运行
        #6跳回producer后返回值为200 OK，向下执行打印200 OK
        print('[P]Cousumer return %s' % r)
    #7直到循环结束，跳出关闭producer 
    c.close()

c=consumer()
producer(c)
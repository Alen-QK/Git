#矩阵相乘问题
l=[[1,2],[2,1],[8,9]]
k=[[1,2],[3,4]]
g=[]

def jugde(l,k):
    if (len(l)==len(k[0])):
        return 1
    else :
        return 0

def mmult(l,k):
    if (jugde(l,k)==1):
        print("可以相乘")
    else :
        print("不可以相乘")
        return
    zipped=list(zip(*l))
    for j in range(len(k)):
        tlist=[]
        for i in range(len(zipped)):
            tlist.append(sum(list(map(lambda a,b: a*b,zipped[i],k[j]))))
        g.append(tlist)
    print(g)
mmult(l,k)




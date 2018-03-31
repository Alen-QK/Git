def triangles():
	l=[1]
	while 1:
		yield l
		l=[l[i]+l[i+1] for i in range(len(l)-1)]#记住range没有指定的话是从0开始，比如l[1,2,1],len(l)是3，range(len(l)-1)就是(0,1)
		l=[1]+l+[1]
#l[0]和l=[0]	是两回事，别搞混了	
n=0
for t in triangles():
	print(t)
	n=n+1
	if n==10:
		break

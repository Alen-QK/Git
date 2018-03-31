def triangles():
	l=[1]
	while 1:
		yield l
		l=[l[i]+l[i+1] for i in range(len(l)-1)]
		l=[1]+l+[1]		
n=0
for t in triangles():
	print(t)
	n=n+1
	if n==10:
		break

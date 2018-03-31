def hahaha():
	l=[1]
	while 1:
		yield l
		l=[l[i]+l[i+1] for i in range(len(l)-1)]
		l=l
		
n=0
for t in hahaha():
	print(t)
	n=n+1
	if n==10:
		break

from functools import reduce
def str2(s):
	def a(x,y):
		return x*10+y
	def char(s):
		return {'1':1,'2':2,'3':3,'4':4,'5':5,'6':6}[s]
	s1=s.split('.')[0]
	s2=s.split('.')[1]
	num=reduce(a,map(char,list(s1)))+reduce(a,map(char,list(s2)))/(10**len(s2))
	return num
	
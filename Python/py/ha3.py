import math
def quadratic(a,b,c):
	z=b*b-4*a*c
	if  z>=0:
		x=(-b+math.sqrt(z))/(2*a)
		y=(-b-math.sqrt(z))/(2*a)
	else:
		print('无解')
	print(x,y)
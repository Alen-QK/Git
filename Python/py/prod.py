from functools import reduce
def prod(l):
	def fn(x,y):
		return x*y
	return reduce(fn,l)
print(prod([3,5,7,9]))
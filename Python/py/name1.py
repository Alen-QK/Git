def normalize(name):
	return str.title(name)
l1=['adam','LISA','barT']
l2=list(map(normalize,l1))
print(l2)
l=[('Bob',75),('Adam',92),('Bart',66),('Lisa',88)]
def by_score(t):
	return t[1]
l2=sorted(l,key=by_score,reverse=True)
print(l2)
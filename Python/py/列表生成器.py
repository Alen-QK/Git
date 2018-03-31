l1=['Hello','World',18,'Apple',None]
l2=[s.lower() for s in l1 if isinstance(s,str)==True]
print(l2)
import string
from collections import Counter

l=[]
g=[]
dic={}

with open('/Users/Issac/Documents/Python/data.txt','r') as f:
    for line in f.readlines():
        l.append(line.strip())
        ls="".join(l)
tls=ls.split( )
c=Counter(tls)
k=list(c.items())

for i in range(len(k)):
    if k[i][0] not in string.punctuation:
        g.append(k[i][0])
#print(tls)

for i in range(len(g)):
    dic.update({g[i]:i})
#print()

for i in range(len(tls)):
    if dic.get(tls[i],-1)!=-1:
        tls[i]=dic[tls[i]]
print(tls)

# vec=[0]*len(dic)
# print(vec)













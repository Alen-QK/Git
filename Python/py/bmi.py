a=input('pls input your height:')
b=input('pls input your weight:')
x=float(a)
y=float(b)
bmi=y/x*x
if bmi<18.5:
	print('过轻')
elif 18.5<bmi<25:
	print('正常')
elif 25<bmi<28:
	print('过重')
elif 28<bmi<32:
	print('肥胖')
else:
	print('严重肥胖')
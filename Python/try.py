try:
	print('try...')
	r=10/int('0')
	print('result:',r)
except ValueError as e:
	print('ValueError:',e)
except ZeroDivisionError as e:
	print('except:',e)
else:
	print('No error')
finally:
	print('finally...')
print('END')
import re

re_email=re.compile(r'([0-9a-zA-Z\.]+)@(\w+).([a-z]{3})')
def match(email):
	if re_email.match(email):
		print('%s is an email' % email)
	else:
		print('%s is not an email' % email)
match('someone@gmail.com')
match('bill.gates@microsoft.com')
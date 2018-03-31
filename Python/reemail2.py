import re

re_email=re.compile(r'<([0-9a-zA-Z\s]+)>\s([0-9a-zA-Z\.]+)@(\w+)\.([a-z]{3})')
def match(email):
	if re_email.match(email):
		print(re_email.match(email).group(1))
	else:
		print('error')
match('<Tom Paris> tom@voyager.org')

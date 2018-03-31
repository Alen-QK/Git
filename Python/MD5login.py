# -*- coding: utf-8 -*-
import hashlib, random

db={}

def register(username,pwd):
	db[username]=get_md5(pwd+username+'the-salt')

def get_md5(s):
	md5=hashlib.md5()
	md5.update(s.encode('utf-8'))
	return md5.hexdigest()
'''
def salt(st='the-salt'):
	st=''.join([chr(random.randint(48, 122)) for i in range(20)])
	return st
'''
def login(username,pwd):
	if username in db and db[username]==get_md5(pwd+username+'the-salt'):
		print('login success!')
	else:
		print('login error!')

register('xiaoming','123456')
login('xiaoming','123456')
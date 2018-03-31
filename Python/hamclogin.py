import hashlib,hmac,re
db={}
def register(username,password):
    user_password=username+password
    db[username]=get_md5(user_password)
    print('注册成功')
    print('请登录')
def get_md5(user_password):
    key=b'xr'
    message= bytes(user_password,encoding='utf-8')
    h=hmac.new(key,message,digestmod='MD5')
    return h.hexdigest()
def login(username,password):
    user_password=username+password
    md_password=get_md5(user_password)

if md_password==db[username]:
    print('登录成功')
    return True
else:
    print('登录失败,请重新登录')

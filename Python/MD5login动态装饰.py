import hashlib

def salt(salt="the-salt"):
    def f(fun):
        def wrapper(*args,**kw):
            args2=list(args)
            args2[0]+=salt
            return fun(args2,**kw)
        return wrapper
    return f
@salt()
def get_md5(s):
    md5=hashlib.md5()
    md5.update(str.encode("utf-8"))
    return md5.hexdigest()

# 无装饰器时使用
def md5_salt(s,salt="the-salt"):
    return get_md5(s+salt())
db={}
def regist(username,password):
    global db
    db[username]=get_md5(password+username)

print("用户注册:")
regist_username=str(input("请输入用户名:"))
regist_password=str(input("请输入密码:"))
regist(regist_username,regist_password)

print("用户登录:")
username=str(input("请输入用户名:"))
password=str(input("请输入密码:"))
if username in db and db[username]==get_md5(password+username):
    print("验证通过")
else:
    print("用户名或密码错误!")
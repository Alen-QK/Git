from flask import Flask
# from flask import request
# from flask import redirect
from flask_script import Manager

app = Flask(__name__)

manager = Manager(app)

@app.route('/')
def home():
    return '<h1>hello, world!</h1>'
    # user_agent = request.headers.get('User-Agent')
    # return '<p>Your browser is %s</p>' % user_agent
    # return redirect('https://www.baidu.com')

@app.route('/user/<name>')
def user(name):
    return '<h1>hello, %s!</h1>' % name or 'web'

if __name__ == '__main__':
    manager.run()
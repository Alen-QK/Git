import requests

response = requests.get('https://www.moyui.site/api/articleitems?limit=15&page=1', headers = {'user-agent': 'Mozilla/5.0'})
print(response.status_code, response.reason)
for name, value in response.headers.items():
    print('%s:%s' % (name, value))
print(response.json())
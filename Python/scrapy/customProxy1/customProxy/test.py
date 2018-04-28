import json

with open('pool.json', 'r') as f:
    data = json.load(f)
    print(data)
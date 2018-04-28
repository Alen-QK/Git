import re
import json

# print(musicname.match('\n            Viva La Vida\n                ').group(2))
musicname = re.compile(r'^(\n\s{12})(.*)(\n\s+)$')
musicinfo = re.compile(r'^(\w+\s?.+)\s/\s(\d{4}\-?\d{0,2}\-?\d{0,2})\s/\s(.*)\s/\s(.*)\s/\s(.+)$')
musicnum = re.compile(r'^(\n.{21}\n.{28})(\d+)(人评价\n.{21}\n.{16})$')

with open('D:/Git/Python/scrapy/doubanmusic/250.json', 'r', encoding= 'utf-8') as f:
     load_dict = json.load(f)

musiclist = []
# print(musicnum.match(r'\n                    (\n                            100891人评价\n                    )\n                ').group(2))
for info in load_dict:
    # print(info['music_name'])
    # print(type(float(info['music_rating'])))
    # print(musicname.match(info['music_name']).group(2),musicinfo.match(info['music_info']).group(5))
    # print(musicnum.match(info['music_num']).group(2))
    musicdict = {}
    musicdict['musicname'] = musicname.match(info['music_name']).group(2)
    musicdict['author'] = musicinfo.match(info['music_info']).group(1)
    musicdict['date'] = musicinfo.match(info['music_info']).group(2)
    musicdict['type'] = musicinfo.match(info['music_info']).group(3) 
    musicdict['medium'] = musicinfo.match(info['music_info']).group(4)
    musicdict['style'] = musicinfo.match(info['music_info']).group(5)
    musicdict['rate'] = float(info['music_rating'])
    musicdict['feedback'] = int(musicnum.match(info['music_num']).group(2))
    musiclist.append(musicdict)

print(musiclist)
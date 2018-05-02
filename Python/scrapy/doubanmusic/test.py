import re
import json
from pyecharts import Bar
from pyecharts import Pie
from pyecharts import Line
from collections import Counter

# print(musicname.match('\n            Viva La Vida\n                ').group(2))
musicname = re.compile(r'^(\n\s{12})(.*)(\n\s+)$')
musicinfo = re.compile(r'^(\w+\s?.+)\s/\s(\d{4})(\-?\d{0,2}\-?\d{0,2})\s/\s(.*)\s/\s(.*)\s/\s(.+)$')
musicnum = re.compile(r'^(\n.{21}\n.{28})(\d+)(人评价\n.{21}\n.{16})$')

with open('D:/Git/Python/scrapy/doubanmusic/250.json', 'r', encoding= 'utf-8') as f:
     load_dict = json.load(f)

musiclist = []
# print(musicnum.match(r'\n                    (\n                            100891人评价\n                    )\n                ').group(2))
for info in load_dict:
    # print(info['music_name'])
    # print(type(float(info['music_rating'])))
    # print(musicname.match(info['music_name']).group(2),musicinfo.match(info['music_info']).group(6))
    # print(musicnum.match(info['music_num']).group(2))
    musicdict = {}
    musicdict['musicname'] = musicname.match(info['music_name']).group(2)
    musicdict['author'] = musicinfo.match(info['music_info']).group(1)
    musicdict['date'] = musicinfo.match(info['music_info']).group(2)
    musicdict['type'] = musicinfo.match(info['music_info']).group(4) 
    musicdict['medium'] = musicinfo.match(info['music_info']).group(5)
    musicdict['style'] = musicinfo.match(info['music_info']).group(6)
    musicdict['rate'] = float(info['music_rating'])
    musicdict['feedback'] = int(musicnum.match(info['music_num']).group(2))
    musiclist.append(musicdict)

# print(musiclist)

# 中英文歌曲数量
# engname = re.compile(r'[a-zA-Z\s]+')
# chname = re.compile(r'[\u4e00-\u9fa5\s]+')
# englist = [] 
# chlist = []
# for info in musiclist:
#     if engname.match(info['author']):
#         englist.append(info['author'])
#     elif chname.match(info['author']):
#         chlist.append(info['author'])
# attr = ['英文', '中文']
# v1 = [len(englist),0]
# v2 = [0, len(chlist)]
# bar = Bar('中英文歌曲数量')
# bar.add('英文', attr, v1, is_stack=True)
# bar.add('中文', attr, v2, is_stack=True)
# bar.render()

# 歌曲发行年代分布
# date = []
# attr = []
# for info in musiclist:
#     date.append(int(info['date']))
# mdate = list(set(sorted(date)))
# a = Counter(date)
# mdatecount = []
# for i in range(0,len(a)):
#     mdatecount.append(sorted(a.most_common())[i][1])
# for item in mdate:
#     attr.append(str(item))
# pie = Pie("发行年代构成", title_pos='right')
# pie.add('',attr, mdatecount, is_label_show=True, legend_top='center', legend_orient='vertical', legend_pos='left')
# pie.show_config()
# pie.render()

# 风格分布
# attr = []
# newattr = []
# for info in musiclist:
#     attr.append(info['style'])
# a = Counter(attr)
# mstylecount = []
# for i in range(0,len(a)):
#     mstylecount.append(sorted(a.most_common())[i][1])
#     newattr.append(sorted(a.most_common())[i][0])
# pie = Pie('音乐风格分布', title_pos='center', width=900)
# pie.add("风格", newattr, mstylecount,center=[75,50], radius=[30,75], is_legend_show=True, is_label_show=True, legend_orient='vertical', legend_top='center')
# pie.show_config()
# pie.render()

# 评分分布
# attr = []
# newattr = []
# for info in musiclist:
#     attr.append(info['rate'])
# a = Counter(attr)
# mrate = []
# for i in range(0,len(a)):
#     mrate.append(sorted(a.most_common())[i][1])
#     newattr.append(sorted(a.most_common())[i][0])
# line = Line('评分分布')
# line.add('评分', newattr, mrate, is_smooth=True)
# line.render(path='评分分类.html')


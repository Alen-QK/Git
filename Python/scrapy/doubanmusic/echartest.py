from pyecharts import Bar

attr = ['a', 'b', 'c', 'd', 'e']
v1 = [2.0, 4.9, 7.0, 23.2, 25.6]
v2 = [2.6, 5.9, 9.0, 26.4, 28.7]
bar = Bar('Bar chart', 'year')
bar.add('ppp', attr, v1, mark_line=['average'], mark_point=['max, min'])
bar.add('eva', attr, v2, mark_line=['average'], mark_point=['max, min'])
bar.render()
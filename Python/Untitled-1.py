# def merge(row):
#     pair = False
#     new_row = []
#     for i in range(len(row)):
#         if pair:
#                         #如果row当中邻近的两个值相等则在new_row中追加一个2倍该值，即2048中的合并
#             new_row.append(2 * row[i])
#                         #给score加上相同的分数
# #            self.score += 2 * row[i]
#                         #再将pair置假
#             pair = False
#         else:
#             if i + 1 < len(row) and row[i] == row[i + 1]:
#                 pair = True
#                 new_row.append(0)
#             else:
#                 new_row.append(row[i])
#         assert len(new_row) == len(row)
#         return new_row

row = [2,2,0,4,8,2,4,4]
pair = False
new_row = []
for i in range(len(row)):
    if pair:
                        #如果row当中邻近的两个值相等则在new_row中追加一个2倍该值，即2048中的合并
        new_row.append(2 * row[i])
                        #给score加上相同的分数
#            self.score += 2 * row[i]
                        #再将pair置假
        pair = False
    else:
        if i + 1 < len(row) and row[i] == row[i + 1]:
            pair = True
            new_row.append(0)
        else:
            new_row.append(row[i])
assert len(new_row) == len(row)
print(new_row)
import curses
from random import randrange,choice
from collections import defaultdict

#用户行为
actions = ['Up', 'Left', 'Down', 'Right', 'Restart', 'Exit']
letter_codes = [ord(ch) for ch in 'WASDRQwasdrq']
#将用户动作与键位绑定
actions_dict = dict(zip(letter_codes, actions * 2))

def get_user_action(keyboard):
    char = 'N'
    #循环等待输入有效值
    while char not in actions_dict:
        char = keyboard.getch()
    #返回输入的有效值
    return actions_dict[char]

def transpost(field):
    #将矩阵以列的形式切分,行列转置
    return [list(row) for row in zip(*field)]

def invert(field):
    #逆置矩阵
    return [row[::-1] for row in field]

class GameField(object):
    def __init__(self, height=4, width=4, win=2048):
        self.height = height
        self.width = width
        self.win_value = win
        self.score = 0
        self.highscore = 0
        self.reset()
    
    def reset(self):
        if self.score > self.highscore:
            self.highscore = self.score
        self.score = 0
        #制作self.width列self.height行的0矩阵
        self.field = [[0 for i in range(self.width)] for j in range(self.height)]
        self.spawn()
        self.spawn()
    
    def move(self,direction):
        def move_row_left(row):
            def tighten(row):
                #将row当中的非零元素调整至一起，如：row=[1,0,3,4,5,0,0,4,9]->[1, 3, 4, 5, 4, 9,]
                new_row = [i for i in row if i != 0]
                #在new_row后面补0：[1, 3, 4, 5, 4, 9, 0, 0, 0]
                new_row += [0 for i in range(len(row)-len(new_row))]
                return new_row
            
            def merge(row):
                pair = False
                new_row = []
                for i in range(len(row)):
                    if pair:
                        #如果row当中邻近的两个值相等则在new_row中追加一个2倍该值，即2048中的合并
                        new_row.append(2 * row[i])
                        #给score加上相同的分数
                        self.score += 2 * row[i]
                        #再将pair置假
                        pair = False
                    else:
                        if i + 1 < len(row) and row[i] == row[i + 1]:
                            pair = True
                            #如果邻近的两个值相等，先向new_row中插入一个0，意指向右合并了，此地留下一个0
                            new_row.append(0)
                        else:
                            #如果并不相等，按原值插入就可
                            new_row.append(row[i])
                #直到new_row长度和row长度相等才能返回            
                assert len(new_row) == len(row)
                return new_row
#具体看这段代码：
# row = [2,2,0,4,8,2,4,4]
# pair = False
# new_row = []
# for i in range(len(row)):
#     if pair:
#                         #如果row当中邻近的两个值相等则在new_row中追加一个2倍该值，即2048中的合并
#         new_row.append(2 * row[i])
#                         #给score加上相同的分数
# #            self.score += 2 * row[i]
#                         #再将pair置假
#         pair = False
#     else:
#         if i + 1 < len(row) and row[i] == row[i + 1]:
#             pair = True
#             new_row.append(0)
#         else:
#             new_row.append(row[i])
# assert len(new_row) == len(row)
# print(new_row)    

            #先挤到一起再合并再挤到一起
            return tighten(merge(tighten(row)))
        
        moves = {}
        #利用move_row_left对矩阵做合并操作
        moves['Left'] = lambda field: [move_row_left(row) for row in field]
        #对Left操作做逆置
        moves['Right'] = lambda field: invert(moves['Left'](invert(field)))
        #对Left操作做转置
        moves['Up'] = lambda field: transpost(moves['Left'](transpost(field)))
        #同上
        moves['Down'] = lambda field: transpost(moves['Right'](transpost(field)))
        
        #如果指令在moves的范围内
        if direction in moves:
            #并且可以向这个方向移动（通过move_is_possible函数判断）
            if self.move_is_possible(direction):
                #就通过moves这个字典中的键所对应的方法来变更矩阵
                self.field = moves[direction](self.field)
                self.spawn()
                return True
            else:
                return False
        
    def is_win(self):
        #先判断矩阵每一行是否有值大于等于获胜值，用any填充field，再用any判断当前矩阵中是否有非false的值，根据第二层返回值，有即获胜，无则失败
        return any(any(i >= self.win_value for i in row) for row in self.field)

    def is_gameover(self):
        #判断move在action中是否还可以行动，并返回与其相反的值（即表达出无法再行动的意思）
        return not any(self.move_is_possible(move) for move in actions)
    
    def draw(self, screen):
        help_string1 = '(W)Up (S)Down (A)Left (D)Right'
        help_string2 = '        (R)Restart (Q)Exit'
        gameover_string = '     Game Over'
        win_string = '      You Win!'
        def cast(string):
            #curses包内的addstr方法将以上字符串显示在CMD中
            screen.addstr(string + '\n')

        def draw_hor_separator():
            line = '+' + ('+------' * self.width + '+')[1:]
            separator = defaultdict(lambda: line)
            #如果draw_hor_separator中没有counter
            if not hasattr(draw_hor_separator, "counter"):
                draw_hor_separator.counter = 0
            #先将draw_hor_separator.counter置0然后，用separator调用它，创建一个defaultdict,然后用cast函数来绘制
            cast(separator[draw_hor_separator.counter])
            #draw_hor_separator.counter自增
            draw_hor_separator.counter += 1
        
        def draw_row(row):
            cast(''.join('|{: ^5}'.format(num) if num > 0 else '|      ' for num in row) + '|')

        #编写控制界面的相关逻辑
        screen.clear()
        cast('SCORE: '+ str(self.score))
        if 0 != self.highscore:
            cast('HIGHSCORE: ' + str(self.highscore))
        for row in self.field:
            draw_hor_separator()
            draw_row(row)
        draw_hor_separator()
        if self.is_win():
            cast(win_string)
        else:
            if self.is_gameover():
                cast(gameover_string)
            else:
                cast(help_string1)
        cast(help_string2)
    
    def spawn(self):
        #为2048每次行动创建随机的一个2或4的值
        new_element = 4 if randrange(100) > 89 else 2
        #从矩阵中当前值为0的坐标内随机挑选一个作为新值的位置
        (i,j) = choice([(i,j) for i in range(self.width) for j in range(self.height) if self.field[i][j] == 0])
        self.field[i][j] = new_element

    def move_is_possible(self, direction):
        def row_is_left_movable(row):
            def change(i):
                if row[i] == 0 and row [i+1] != 0:
                    return True
                if row[i] != 0 and row [i+1] == row[i]:
                    return True
                return False
            return any(change(i) for i in range(len(row) - 1))
        check = {}
        check['Left'] = lambda field: any(row_is_left_movable(row) for row in field)
        check['Right'] = lambda field: check['Left'](invert(field))
        check['Up'] = lambda field: check['Left'](transpost(field))
        check['Down'] = lambda field: check['Right'](transpost(field))
        
        if direction in check:
            return check[direction](self.field)
        else:
            return False

def main(stdscr):
    def init():
        #重置游戏
        game_field.reset()
        return 'Game'

    def not_game(state):
        #绘制游戏结束或胜利时的界面
        game_field.draw(stdscr)
        #获取用户输入的指令，判断重启还是结束
        action = get_user_action(stdscr)
        #保持停留在当前状态，无指令就会在当前界面循环
        responses = defaultdict(lambda: state)
        responses['Restart'],responses['Exit'] = 'Init', 'Exit'
        return responses[action]
        
    def game():
        #绘制当前游戏状态
        game_field.draw(stdscr)
        #读取用户输入的指令
        action = get_user_action(stdscr)

        if action == 'Restart':
            return 'Init'
        if action == 'Exit':
            return 'Exit'
        if game_field.move(action):
            if game_field.is_win():
                return 'Win'
            if game_field.is_gameover():
                return 'Gameover'
        return 'Game'
    
    state_actions = {'Init': init, 'Win': lambda: not_game('Win'), 'Gameover': lambda: not_game('Gameover'), 'Game': game}

    curses.use_default_colors()

    #设定获胜值为32
    game_field = GameField(win=32)
    state = 'Init'
    while state != 'Exit':
        state = state_actions[state]()

curses.wrapper(main)
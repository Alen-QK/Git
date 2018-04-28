# -*- coding: utf-8 -*-

import json
import random

class RandomRroxy(object):
    with open('D:/Git/Python/scrapy/doubanmusic/doubanmusic/middleware/pool.json', 'r', encoding='utf-8') as f:
        load_dict = json.load(f)
        #print(load_dict)

    def process_request(self, request, spider):
        proxy = random.choice(self.load_dict)
        #print(proxy)
        if proxy['proxy_type'] == 'HTTP':
            #print(proxy['proxy_address'], proxy['proxy_port'])
            request.meta['proxy'] = 'http://%s:%s' % (proxy['proxy_address'], proxy['proxy_port'])
        else:
            #print(proxy['proxy_address'], proxy['proxy_port'])
            request.meta['proxy'] = 'https://%s:%s' % (proxy['proxy_address'], proxy['proxy_port'])
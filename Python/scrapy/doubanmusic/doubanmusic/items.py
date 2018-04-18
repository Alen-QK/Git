# -*- coding: utf-8 -*-

# Define here the models for your scraped items
#
# See documentation in:
# https://doc.scrapy.org/en/latest/topics/items.html

import scrapy


class DoubanmusicItem(scrapy.Item):

    music_name = scrapy.Field()
    music_info = scrapy.Field()
    music_rating = scrapy.Field()
    music_num = scrapy.Field()

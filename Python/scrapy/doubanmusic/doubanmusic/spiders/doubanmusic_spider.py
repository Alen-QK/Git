import scrapy
from scrapy import Request
from .items import DoubanmusicItem

class DoubanMusic_spider(scrapy.Spider):
    name = 'DoubanMusic_top250'

    def start_requests(self):
        urls = ['https://music.douban.com/top250?start=0']
        for url in urls:
            yield scrapy.Request(url, callback=self.parse)
    
    def parse(self, response):
        item = DoubanmusicItem()
        for musicls in response.css("div.indent table"):
            item['music_name'] = musicls.css("div.pl2")[0].css("a::text").extract_first()
            item['music_info'] = musicls.css("p.pl::text").extract_first()
            item['music_rating'] = musicls.xpath(".//div[@class='star clearfix']/span[@class='rating_nums']/text()").extract_first()
            item['music_num'] = musicls.xpath(".//div[@class='star clearfix']/span[@class='pl']/text()").extract_first()
            yield item

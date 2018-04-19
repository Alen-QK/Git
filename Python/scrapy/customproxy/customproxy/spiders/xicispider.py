import scrapy
from .items import CustomproxyItem

class xiciSpider(scrapy.Spider):
    name = 'xicispider'
    start_list = []
    for i in range(1,10):
        url = r'http://www.xicidaili.com/nn/%s' % str(i)
        start_list.append(url)
    strat_urls = start_list

    def start_requests(self):
        user_agent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11"
        headers = {'User-Agent': user_agent}
        for url in self.strat_urls:
            yield scrapy.Request(url= url, headers= headers, method= 'GET', callback= self.parse)
    
    def parse(self, response):
        lists = response.xpath('//*[@id="ip_list"]/tr')
        with open('data.txt',"a") as wd:
            for index, tdinfo in enumerate(lists):
                if index != 0:
                    ipline = tdinfo.xpath('td[2]/text()').extract_first() +":"+tdinfo.xpath('td[3]/text()').extract_first()
                    print(ipline)
                    wd.write(ipline+u"\n")
                    # xiciI = CustomproxyItem()
                    # xiciI['ipaddress'] = tdinfo.xpath('td[2]/text()').extract_first()
                    # xiciI['dk'] = tdinfo.xpath('td[3]/text()').extract_first()
                    # yield xiciI
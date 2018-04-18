import scrapy

class QuotesSpider(scrapy.Spider):
    name = "gao"
    start_urls = [
        "https://www.moyui.site/",
    ]

    def prase(self, response):
        for body in response.css('div.article-item'):
            yield{
                'p': body.css('p.article-item-abstract::text').extract_first(),
            }
        # next_page = response.css('button.article-item-all a::attr(href)').extract_first()
        # if next_page is not None:
        #     next_page = response.urljoin(next_page)
        #     yield scrapy.Request(next_page, callback=self.prase)
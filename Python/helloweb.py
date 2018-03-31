def application(environ, start_response):
	start_response('200 OK', [('Content-Type', 'text/html')])
	body = '<h1></h1>hello, %s!' % (environ['PATH_INFO'][1:] or 'web')
	return [body.encode('utf-8')]
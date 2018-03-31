class Screen(object):
	@property
	def width(self):
		return self._width
	@width.setter
	def width(self,value):
		if(value<0):
			print("error")
		else:
			self._width=value
	@property
	def height(self):
		return self._height
	@height.setter
	def height(self,value):
		if(value<0):
			print("error")
		else:
			self._height=value
	@property
	def resolutin(self):
		return self._width*self._height
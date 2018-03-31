import re
from datetime import datetime, timezone, timedelta

def to_timestamp(dt_str, tz_str):
	tz_re=re.compile(r'^UTC([\+\-0-9]+)\:00')
	tz_utc=int(re.match(tz_re,tz_str).group(1))
	cday=datetime.strptime(dt_str,'%Y-%m-%d %H:%M:%S')
	c_dt=cday.replace(tzinfo=timezone(timedelta(hours=tz_utc)))
	tp=c_dt.timestamp()
	print(tp)

t1 = to_timestamp('2015-6-1 08:10:30', 'UTC+7:00')
t2 = to_timestamp('2015-5-31 16:10:30', 'UTC-09:00')


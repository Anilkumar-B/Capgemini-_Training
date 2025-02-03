import threading
import time                                                                                         
import requests
def scrape_website(url,results):
    response=requests.get(url)
    html_content=response.text
    results.append(f"fetched data from {url} and response is {html_content}")
url=[
    "https://www.movierulz-movierulz.com/"
] 
results=[]
threads=[]
for site in url:
    thread=threading.Thread(target=scrape_website,args=(site,results))
    threads.append(thread)
    thread.start()
for thread in threads:
    thread.join()
with open("context.html","w") as file:
        for result in results:
             file.write(result)
import threading
import time
import queue

def producer(q):
    for i in range(5):
        time.sleep(1)
        q.put(1)
        print(f"produced: {i}")
def consumer(q):
    while True:
        item=q.get()
        if item is None:
            break
        print(f"Conusmed : {item}")
        time.sleep(2)
q=queue.Queue()
producer_thread=threading.Thread(target=producer, args=(q,))
consumer_thread=threading.Thread(target=consumer,args=(q,))

producer_thread.start()
consumer_thread.start()
from socket import AF_INET, socket, SOCK_STREAM
from threading import Thread
import time


def send():  
    """Handles sending of messages."""
    msg = "Hello from client 2"
    client_socket.send(bytes(msg, "utf8"))
    if msg == "{quit}":
        client_socket.close()
    



HOST = '127.0.0.1' 
PORT = 33000
BUFSIZ = 1024
ADDR = (HOST, PORT)

client_socket = socket(AF_INET, SOCK_STREAM)
client_socket.connect(ADDR)
#print(dir(client_socket))

def receive():
    """Handles receiving of messages."""
    try:
        msg = client_socket.recv(BUFSIZ).decode("utf8")
        print(msg+"\n")
        print()
    except OSError:  # Possibly client has left the chat.
        print("problems")


while True:     
    send()
    data = client_socket.recv(1024)
    #print("received:", data.decode())  #### uncomment it to see the result in client
    time.sleep(3)
    
import socket

class TCPServer:
    def __init__(self, ip, port) -> None:
        self.ip = ip
        self.port = port
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.clients = []

    def connect(self):
        self.sock.bind((self.ip, self.port))
        self.sock.listen(5)
        print("Waiting for connections")

    def loop(self):
        try:
            while 1:
                message = input('Enter to listen (or "quit" to exit): ')
                if message == 'quit':
                    break
                newSocket, address = self.sock.accept()
                print("Connected to", address)
                self.clients.append(newSocket)

                while 1:
                    try:
                        rec_data = newSocket.recv(1024)
                        if not rec_data: break

                        print(f"{address[0]}:{address[1]}:", rec_data)

                        newSocket.sendall(rec_data)
                    except:
                        break
                print("No more data from", address)
                
        finally:
            print("Closing")
            newSocket.close()

if __name__ == "__main__":
    server = TCPServer('127.0.0.1', 9000)
    server.connect()
    server.loop()
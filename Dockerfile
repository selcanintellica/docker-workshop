FROM alpine:3.14
WORKDIR /app
COPY . .
RUN apk add --no-cache python3 py3-pip
RUN pip install -r requirements.txt
CMD ["python3", "app.py"]
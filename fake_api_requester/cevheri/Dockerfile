FROM alpine:latest
RUN apk add --no-cache curl
COPY script.sh /app/
WORKDIR /app
CMD ["./script.sh"]
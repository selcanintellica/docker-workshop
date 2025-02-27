#!/bin/sh

API_URL="${API_URL:-https://ornekapi.com/veri}" 
INTERVAL="${INTERVAL:-600}"  

while true; do
  curl "$API_URL"
  sleep "$INTERVAL"
done
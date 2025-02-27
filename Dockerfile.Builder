FROM maven:3.9.9-eclipse-temurin-21 as build
WORKDIR /app
COPY . .
RUN mvn clean package
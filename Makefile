web-dev-1:
	docker-compose run -p 8085:8080 --rm dev-web-app dotnet watch --project  src/WebApplication1/WebApplication1.csproj

web-dev-2:
	docker-compose run -p 8086:8080 --rm dev-web-app dotnet watch --project  src/WebApplication2/WebApplication2.csproj

web-dev-build:
	docker-compose build dev-web-app
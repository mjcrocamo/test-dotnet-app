web-dev:
	docker-compose run -p 8085:8080 --rm test-web-app-1 dotnet watch --project  src/WebApplication1/WebApplication1.csproj

web-dev-build:
	docker-compose build test-web-app-1
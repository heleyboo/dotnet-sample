DOTNET_RUN = dotnet

migration:
	$(DOTNET_RUN) ef migrations add ${name}

dbupdate:
	$(DOTNET_RUN) ef database update

run:
	$(DOTNET_RUN) run

watch:
	$(DOTNET_RUN) watch
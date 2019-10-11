# use official dotnet framwork base image
FROM microsoft/dotnet-framework:latest

# set working directory
WORKDIR /app

# expose port
EXPOSE 8733

# copy exe and all dll files to container
COPY HelloWorldHost/bin/Debug .

# run the service as soon as container spins up
CMD HelloWorldHost.exe
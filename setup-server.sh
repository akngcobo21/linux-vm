```bash
#!/bin/bash
# Azure Ubuntu VM Initial Setup Script

# Update OS packages
sudo apt-get update && sudo apt-get upgrade -y

# Install .NET 8 SDK
sudo apt-get install -y dotnet-sdk-8.0

# Verify installation
dotnet --info

# Create app directory
mkdir -p ~/AzureHttpServer
echo "Setup complete. Navigate to ~/AzureHttpServer and deploy your app."

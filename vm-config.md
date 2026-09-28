# Azure VM Infrastructure Configuration

## Virtual Machine Details
* **Cloud Provider:** Microsoft Azure
* **Resource Group:** `rg-linux-api`
* **VM Name:** `linux-api-server`
* **OS:** Ubuntu Server 24.04 LTS (x64)
* **Size:** Standard_D2als_v7 (2 vCPUs, 4 GB RAM)
* **Default User:** `azureuser`

## Network Security Group (NSG) Inbound Rules

| Priority | Name | Port | Protocol | Source | Action |
| :--- | :--- | :--- | :--- | :--- | :--- |
| 22 | `SSH` | 22 | TCP | Any | Allow |
| 310 | `Allow-HTTP-5000` | 5000 | TCP | Any | Allow |

## How to Connect via SSH
```bash
ssh azureuser@<20.65.91.86>

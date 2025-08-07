FROM jenkins/inbound-agent

# Switch to root to install packages
USER root

# Use noninteractive mode to prevent hangs
ENV DEBIAN_FRONTEND=noninteractive

# Install required tools including zip
RUN apt-get update && \
    apt-get install -y --no-install-recommends \
        curl \
        apt-transport-https \
        ca-certificates \
        gnupg \
        software-properties-common \
        openjdk-17-jdk \
        git \
        zip && \
    apt-get clean && rm -rf /var/lib/apt/lists/*

# ---------------------------------------------
# Install Azure CLI (via Microsoft official method)
# ---------------------------------------------
RUN curl -sL https://aka.ms/InstallAzureCLIDeb | bash

# ---------------------------------------------
# Install .NET 8 SDK for Debian
# ---------------------------------------------
RUN curl -sSL https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -o packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    rm packages-microsoft-prod.deb && \
    apt-get update && \
    apt-get install -y dotnet-sdk-8.0 && \
    apt-get clean && rm -rf /var/lib/apt/lists/*

# Switch back to Jenkins user
USER jenkins

# Set Java environment variables
ENV JAVA_HOME=/usr/lib/jvm/java-17-openjdk-amd64
ENV PATH="$JAVA_HOME/bin:$PATH"
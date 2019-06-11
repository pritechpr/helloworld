#!/bin/bash

#
# Sanity checks
#



#
# Conf files
#

CONF_FILE=("helloworld.webapp/src/App.js")

#
# Ansible
#

ansible-galaxy install -r ansible/requirements.yml

#
# BUILD - PUBLIC_URL
#

PUBLIC_HOST=helloworld-itrellis.you2service.com
#PUBLIC_HOST=localhost

#
# change Public Build 
#

git checkout f666682 -- "$CONF_FILE"

sed -i "s/localhost/$PUBLIC_HOST/g" "$CONF_FILE" 

cd ansible

ansible-playbook -u root -i inventory master-play.yml

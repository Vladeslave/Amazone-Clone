#!groovy
//  groovy Jenkinsfile
pipeline  {
    agent any;
    stages {
        
         stage("Backup files")
         {
             steps{
                sh """
                #!/bin/bash
                hostname
                """
             }
         }
        stage("Change IP in axios.js")
         {
             steps{
                sh "find FrontEnd/my-app/ -type f -exec sed  -i 's#http://localhost:5034#https://10.20.34.195/api#g' {} +"
             }
         }
    }
}

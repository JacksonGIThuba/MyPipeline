pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo "building ..."
            }
        }
        
        stage('Unit and Integration Tests') {
            steps {
                echo "hi"
            }
        }

        stage('Code Analysis') {
            steps {
                echo "hi"
            }
        }

        stage('Security Scan') {
            steps {
                echo "hi"
            }
        }

        stage('Deploy to Staging') {
            steps {
                echo "hi"
            }
        }

        stage('Integration Tests on Staging') {
            steps {
                echo "hi"
            }
        }

        stage('Deploy to Production') {
            steps {
                echo "hi"
            }
        }
    }

    post {
        success {
            mail to: "jacksonbouwman12@gmail.com"
            subject: "build status email"
            body: "this worked blud"
        }
        failure {
            echo "process failed"
        }
    }
}

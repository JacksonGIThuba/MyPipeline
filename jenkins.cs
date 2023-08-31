pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                // Use your build tool (e.g., Maven) to build the code
                echo "building ..."
            }
        }
        post {
            success {
            // Send email notification on success
            mail to: "jacksonbouwman12@gmail.com"
            subject: "build status email"
            body: "this worked blud"
            }failure {
            // Send email notification on failure

            }
        }

        stage('Unit and Integration Tests') {
            steps {
                // Run unit and integration tests
            }
        }

        stage('Code Analysis') {
            steps {
                // Integrate a code analysis tool (e.g., SonarQube)
            }
        }

        stage('Security Scan') {
            steps {
                // Integrate a security scanning tool
            }
        }

        stage('Deploy to Staging') {
            steps {
                // Deploy to staging environment (e.g., AWS EC2)
            }
        }

        stage('Integration Tests on Staging') {
            steps {
                // Run integration tests on staging
            }
        }

        stage('Deploy to Production') {
            steps {
                // Deploy to production environment (e.g., AWS EC2)
            }
        }
    }

    post {
        success {
            // Send email notification on success
            mail to: "jacksonbouwman12@gmail.com"
            subject: "build status email"
            body: "this worked blud"
        }
        failure {
            // Send email notification on failure

        }
    }
}

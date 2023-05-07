pipeline {
  agent any
  stages {
    stage('Start container') {
      steps {
        sh 'docker compose build'
        sh 'docker compose ps'
      }
    }
  }
  post {
    always {
      sh 'docker compose down --remove-orphans -v'
      sh 'docker compose ps'
    }
  }
}
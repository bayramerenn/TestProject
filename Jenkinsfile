pipeline {
  agent any
  stages {
    stage('Start container') {
      steps {
        sh 'docker compose up -d'
        sh 'docker compose ps'
      }
    }
  }
//   post {
//     always {
//       sh 'docker compose down --remove-orphans -v'
//       sh 'docker compose ps'
//     }
//   }
}
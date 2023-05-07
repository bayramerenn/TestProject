pipeline {
  agent any
  stages {
    stage('Start container') {
      steps {
        sh 'docker compose down'  // Var olan projeyi durdur
        sh 'docker ps'
        sh 'docker compose build' // Yeni Docker imajlarını oluştur
        sh 'docker compose up -d' // Yeniden oluşturulan projeyi başlat
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

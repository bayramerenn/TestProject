pipeline {
  agent any
  stages {
    stage('Start container') {
              // Değişiklik yapılan servis için deploy işlemini gerçekleştir
              //C:\Users\Bayram\source\repos\TestProject\TestProject\TestProject.csproj
              when {
                changeset "TestProject/TestProject/*"
              }
              steps {
                sh 'docker rm -f testapi'
                sh 'docker image rm testproject'  // Var olan projeyi durdur
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

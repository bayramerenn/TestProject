pipeline {
  agent any

    environment {
         containerName = 'testapi'
         imageName = 'testproject'
    }
   stages {
    stage('Start container') {
              when {
                changeset "**/TestProject/**"
              }
              steps {
              

                // Konteyneri durdur ve sil
                sh "docker stop ${containerName} || true"
                sh "docker rm ${containerName} || true"

                // Görüntüyü sil
                sh "docker image rm ${imageName} || true"

                // Yeni Docker imajlarını oluştur ve projeyi başlat
                sh 'docker compose build'
                sh 'docker compose up -d'
              }
            }
   
  }

}


//   post {
//     always {
//       sh 'docker compose down --remove-orphans -v'
//       sh 'docker compose ps'
//     }
//   }

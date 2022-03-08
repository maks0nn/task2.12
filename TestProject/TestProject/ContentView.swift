//
//  ContentView.swift
//  TestProject
//
//  Created by Maksim Maiornikov on 27.02.2022.
//

import SwiftUI

struct ContentView: View {
    var body: some View {
        Button(action:{
            print("test")
        }, label:{Text("Вход")} )
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}

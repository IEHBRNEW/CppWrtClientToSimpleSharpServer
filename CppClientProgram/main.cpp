#include "pch.h"

#include <iostream>

using namespace winrt;
using namespace Windows::Foundation;

int main()
{
    init_apartment();

    SharpClientLib::SharpClient ex;
    wchar_t const* result = ex.GetString(L"http://localhost:8080").c_str();
    std::wcout << result << std::endl;
}
